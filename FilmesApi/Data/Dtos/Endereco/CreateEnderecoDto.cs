﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos.Endereco
{
    public class CreateEnderecoDto
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
    }
}