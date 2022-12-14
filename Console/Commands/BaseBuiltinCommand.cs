using Console.UserInterface;
using Console.UserInterface.UiTypes;

namespace Console.Commands;

public class BaseBuiltinCommand : ICommand
{
    private Terminal? _terminal;
    
    public virtual string Name { get; } = null!; 
    
    public virtual string Description { get; } = null!;
    
    public virtual DateTime? LastRunTime { get; set; } = default;
    
    public virtual int Run(List<string> args, Terminal parent)
    {
        LastRunTime = DateTime.Now;
        _terminal = parent;
        return 0;
    }
    
    /// <summary>
    /// Helper methods, will write to the parents output stream.
    /// Must call <see cref="Run"/> from base before using.
    /// </summary>
    /// <param name="message">The message</param>
    /// <param name="severity">The messages severity</param>
    protected void WriteLine(string message, Severity severity = Severity.None)
    {
        _terminal?.Ui.DisplayLine(message, severity);
    }
    
    /// <summary>
    /// Helper methods, will write to the parents output stream.
    /// Must call <see cref="Run"/> from base before using.
    /// </summary>
    /// <param name="message">The message</param>
    /// <param name="severity">The messages severity</param>
    protected void Write(string message, Severity severity = Severity.None)
    {
        _terminal?.Ui.Display(message, severity);
    }
}