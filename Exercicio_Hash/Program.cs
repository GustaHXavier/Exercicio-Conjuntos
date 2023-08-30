using System.Collections.Generic;
using Entities;

HashSet<Aluno> alunos = new HashSet<Aluno>();
int num = 0;

Console.Write("Quantos estudantes do curso A: ");
int xA = int.Parse(Console.ReadLine());

for (int i = 0; i < xA; i++) {

    num = int.Parse(Console.ReadLine());
    alunos.Add(new Aluno(num));

}

Console.Write("Quantos estudantes do curso B: ");
int xB = int.Parse(Console.ReadLine());

for (int i = 0; i < xB; i++) {

    num = int.Parse(Console.ReadLine());
    alunos.Add(new Aluno(num));

}

Console.Write("Quantos estudantes do curso C: ");
int xC = int.Parse(Console.ReadLine());

for (int i = 0; i < xC; i++) {

    num = int.Parse(Console.ReadLine());
    alunos.Add(new Aluno(num));

}

Console.WriteLine("TOTAL DE ALUNOS: " + alunos.Count);