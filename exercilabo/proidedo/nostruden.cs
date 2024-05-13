// Check if the file exists at the specified path
if (File.Exists(filePath))
{
    try
    {
        // Attempt to delete the file
        File.Delete(filePath);
        // If successful, the file has been deleted
        Console.WriteLine("File deleted successfully.");
    }
    catch (IOException ioEx)
    {
        // This block catches exceptions related to I/O operations
        Console.WriteLine("An I/O error occurred: " + ioEx.Message);
    }
    catch (UnauthorizedAccessException unAuthEx)
    {
        // This block catches exceptions related to lacking necessary permissions
        Console.WriteLine("Unauthorized access: " + unAuthEx.Message);
    }
}
else
{
    // Inform the user that the file does not exist
    Console.WriteLine("File not found.");
}
