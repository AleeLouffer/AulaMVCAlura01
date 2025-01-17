﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Alura.ListaLeitura.App.Logica
{
    public class CadastroController
    {
        public CadastroController()
        {
        }

        public string Incluir(Livro livro)
        {
            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);
            return"O Livro foi adicionado com sucesso"; 
        }

        public IActionResult ExibeFormulario()
        {
            var html = new ViewResult { ViewName = "formulario" };
            return html;
        }
    }
}
