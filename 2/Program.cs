﻿/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

double GetLens(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double len = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (z1-z2)*(z1-z2));
    return len;
}
Console.WriteLine(GetLens(3, 6, 8, 2, 1, -7));
