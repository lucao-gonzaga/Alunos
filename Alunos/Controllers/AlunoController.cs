using Alunos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alunos.Controllers
{
    public class AlunoController : Controller
    {
        private static IList<Aluno> alunos = new List<Aluno>()
        {
            new Aluno()
            {
                AlunoID = 1,
                Nome = "Lucas",
                Endereço = "Rua X, 225 - Campinas",
                Email = "lucasbenda@outlook.com",
                Telefone = "1234-4321"
            },new Aluno()
            {
                AlunoID = 2,
                Nome = "Eduardo",
                Endereço = "Rua X, 75 - S. J. Barro",
                Email = "eduardo@gmail.com",
                Telefone = "4321-1234"
            },new Aluno()
            {
                AlunoID = 3,
                Nome = "Danilo",
                Endereço = "Rua A, 43 - Ribeirao Preto",
                Email = "daniel@gmail.com",
                Telefone = "4213-5123"
            },new Aluno()
            {
                AlunoID = 4,
                Nome = "Estevao",
                Endereço = "Rua 9, 57 - S. J. Barra",
                Email = "estevao@gmail.com",
                Telefone = "1521-4213"
            },new Aluno()
            {
                AlunoID = 5,
                Nome = "Fulano1",
                Endereço = "Rua B, 25 - Ribeirao Preto",
                Email = "fulano1@gmail.com",
                Telefone = "4123-4121"
            },new Aluno()
            {
                AlunoID = 6,
                Nome = "Fulano2",
                Endereço = "Rua X, 55 - RP",
                Email = "fulano2@gmail.com",
                Telefone = "1334-4321"
            },new Aluno()
            {
                AlunoID = 7,
                Nome = "Fulano3",
                Endereço = "Rua C, 42 - S.J.",
                Email = "fulano3@gmail.com",
                Telefone = "1324-5123"
            },new Aluno()
            {
                AlunoID = 8,
                Nome = "Fulano4",
                Endereço = "Rua 5, 44 - Campinas",
                Email = "fulano4@gmail.com",
                Telefone = "4356-4321"
            },new Aluno()
            {
                AlunoID = 9,
                Nome = "Fulano5",
                Endereço = "Rua 8, 58 - RP",
                Email = "fulano5@gmail.com",
                Telefone = "5125-4321"
            },new Aluno()
            {
                AlunoID = 10,
                Nome = "Fulano6",
                Endereço = "Rua X, 26 - RP",
                Email = "fulano6@gmail.com",
                Telefone = "9879-6781"
            },
        };
        public IActionResult Index()
        {
            return View(alunos);
        }
    }
}
