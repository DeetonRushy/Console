using Console.UserInterface.UiTypes;

namespace Console.UserInterface;

/// <summary>
/// The base for a user interface.
/// </summary>
public interface IUserInterface
{
    /// <summary>
    /// Display a message on the user interface
    /// </summary>
    /// <param name="message">The message to display</param>
    /// <param name="type">The type of message the caller is sending</param>
    public void DisplayLine(string message, Severity type = Severity.None);
    
    /// <summary>
    /// Display a message on the user interface
    /// </summary>
    /// <param name="message">The message to display</param>
    /// <param name="type">The type of message the caller is sending</param>
    public void Display(string message, Severity type = Severity.None);

    public void DisplayLinePure(string message);
    public void DisplayPure(string message);
    
    /// <summary>
    /// Set the user interface's main title.
    /// </summary>
    /// <param name="message">The new title</param>
    public void SetTitle(string message);
    
    /// <summary>
    /// Clear the active display.
    /// </summary>
    public void Clear();
    
    /// <summary>
    /// Read a line from the interfaces stdin.
    /// </summary>
    /// <returns>The line that has been read, after [Enter] has been pressed.</returns>
    public string GetLine();
    
    /// <summary>
    /// The applications message tray. This should be used to display
    /// messages that aren't relevant in the moment, but can be
    /// useful.
    /// </summary>
    public IMessageTray Tray { get; }
}