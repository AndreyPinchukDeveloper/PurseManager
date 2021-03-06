using BudgetManager.Infrastructure.Commands.Base;
using System;

namespace BudgetManager.Infrastructure.Commands
{
    /// <summary>
    /// Main command class
    /// </summary>
    internal class LambdaCommand : Command
    {
        private readonly Action<object> _Execute;//readonly works faster than another
        private readonly Func<object, bool> _CanExecute;
        public LambdaCommand(Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = CanExecute;
        }

        public override bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ?? true;

        public override void Execute(object parameter) => _Execute(parameter);
    }
}
