﻿using System.Diagnostics.CodeAnalysis;
using Laba1.Repositories;
using Spectre.Console;
using Spectre.Console.Cli;

namespace Laba1.Commands
{
    public class PrintAllFigure3DCommand : Command<PrintAllFigure3DCommand.PrintAllFigureSettings>
    {
        public class PrintAllFigureSettings : CommandSettings
        {

        }
        private readonly IFigures3DRepository _figureRepository;
        public PrintAllFigure3DCommand(IFigures3DRepository figureRepository)
        {
            _figureRepository = figureRepository;
        }
        public override int Execute([NotNull] CommandContext context, [NotNull] PrintAllFigureSettings settings)
        {
            var figures = _figureRepository.GetFigures();
            var table = new Table();
            table.Title("[aqua]3D Figures [/]");
            table.AddColumn("Type");
            table.AddColumn("Info");
            table.AddColumn("Area");
            table.AddColumn("Volume");
            for(int i=0; i < _figureRepository.GetCountFigures(); ++i)
            {
                if (i == 10)
                {
                    table.AddRow("...", "...", "...", "...");
                    break;
                }
                table.AddRow(figures[i].GetType().Name, figures[i].ToString(),
                             figures[i].GetArea().ToString(), figures[i].GetVolume().ToString());
            }
            AnsiConsole.Write(table);
            return 0;
        }
    }
}
