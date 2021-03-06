﻿/*
INPUT:
8
1 abc
3 3
2 3
1 xy
3 2
4 
4 
3 1
OUTPUT:
c
y
a

INPUT:
10
1 ewcgpjfh
1 igqsbqyp
1 qsdliigcj
4
3 15
1 iilmgp
2 8
4
2 18
1 scwhors
OUTPUT:
y
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.DataStructure.Stacks
{
    /// <summary>
    /// Simple Text Editor
    /// https://www.hackerrank.com/challenges/simple-text-editor
    /// </summary>
    public class SimpleTextEditor
    {
        /// <summary>
        /// "Client" in command pattern.
        /// </summary>
        public static void Main()
        {
            int commandCount = int.Parse(Console.ReadLine());
            List<Command> cmds = GetCommands(commandCount).ToList();

            Execute(cmds);
        }

        private static void Execute(List<Command> cmds)
        {
            TextEditor textEditor = new TextEditor(cmds);
            textEditor.ExecuteCommands();
        }

        private static IEnumerable<Command> GetCommands(int commandCount)
        {
            for (int i = 0; i < commandCount; i++)
            {
                yield return ParseCommand(Console.ReadLine());
            }
        }

        private static Command ParseCommand(string line)
        {
            var split = line.Split(' ');
            Operator op = (Operator) int.Parse(split[0]);

            string value = string.Empty;
            if (op != Operator.Undo)
                value = split[1];

            TextEditorQuery query = null;
            switch (op)
            {
                case Operator.Append:
                    query = new AppendQuery(value);
                    break;
                case Operator.Delete:
                    query = new DeleteQuery(value);
                    break;
                case Operator.Print:
                    query = new PrintQuery(value);
                    break;
                case Operator.Undo:
                    query = new NullQuery("");
                    break;
            }

            return new Command(query);
        }
    }

    /// <summary>
    /// Invoker in Command pattern.
    /// </summary>
    public class TextEditor
    {
        public IList<Command> Commands { get; set; }
        public Stack<Command> UndoCommands { get; set; } = new Stack<Command>();

        public TextEditor(IList<Command> commands)
        {
            Commands = commands;
        }

        public void ExecuteCommands()
        {
            string text = string.Empty;
            for (int i = 0; i < Commands.Count; i++)
            {
                Command command = Commands[i];

                if (!(command.Query is NullQuery))
                {
                    text = command.Execute(text);

                    if (!(command.Query is PrintQuery))
                        UndoCommands.Push(command);
                }
                else
                {
                    var undoCommand = UndoCommands.Pop();
                    text = undoCommand.Undo();
                }
            }
        }
    }

    public enum Operator
    {
        Append = 1,
        Delete = 2,
        Print = 3,
        Undo = 4
    }

    public interface ICommand
    {
        string Execute(string text);
        string Undo();
    }

    /// <summary>
    /// "Receiver" in Command Pattern
    /// </summary>
    public abstract class TextEditorQuery : ICommand
    {
        public string Text { get; set; }
        public string Value { get; set; }

        protected TextEditorQuery(string value)
        {
            Value = value;
        }

        public abstract string Execute(string text);
        public abstract string Undo();
    }

    public class AppendQuery : TextEditorQuery
    {
        public string PreviousText { get; set; }

        public AppendQuery(string value) : base(value)
        {
        }

        public override string Execute(string text)
        {
            Text = text;
            PreviousText = text;
            return Text + Value;
        }

        public override string Undo()
        {
            Text = PreviousText;
            PreviousText = "";
            return Text;
        }
    }

    public class DeleteQuery : TextEditorQuery
    {
        public string RemovedText { get; set; }

        public DeleteQuery(string value) : base(value)
        {
        }

        public override string Execute(string text)
        {
            Text = text;

            int charactersToDelete = int.Parse(Value);
            var startIndex = Text.Length - charactersToDelete;

            RemovedText = Text.Substring(startIndex);
            Text = Text.Remove(startIndex);

            return Text;
        }

        public override string Undo()
        {
            Text += RemovedText;
            RemovedText = "";
            return Text;
        }
    }

    public class PrintQuery : TextEditorQuery
    {
        public PrintQuery(string value) : base(value)
        {
        }

        public override string Execute(string text)
        {
            Text = text;

            int oneBasedIndex = int.Parse(Value);
            Console.WriteLine(Text[oneBasedIndex - 1]);
            return Text;
        }

        public override string Undo()
        {
            return string.Empty;
        }
    }

    public class NullQuery : TextEditorQuery
    {
        public NullQuery(string value) : base(value)
        {
        }

        public override string Execute(string text)
        {
            return text;
        }

        public override string Undo()
        {
            return null;
        }
    }

    public class Command : ICommand
    {
        public TextEditorQuery Query { get; set; }

        public Command(TextEditorQuery query)
        {
            Query = query;
        }

        public string Execute(string text)
        {
            return Query.Execute(text);
        }

        public string Undo()
        {
            return Query.Undo();
        }
    }
}
