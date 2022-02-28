﻿using System.Collections.Generic;
using Laba1.Model;

namespace Laba1.Repositories
{
    public interface IFigures3DRepository
    {
        void AddFigure(Figure3D figure , int index);
        void RemoveFigure(int index);
        List<Figure3D> GetFigures();
        void RemoveAllFigures();
    }
}