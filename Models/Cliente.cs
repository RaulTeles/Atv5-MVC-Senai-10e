using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LHPet10e.Models
{
    // Criando a classe Cliente
    public class Cliente
    {
        public int Id{get;set;}
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
        public string? Paciente { get; set; }

        // Criando o construtor da class
        public Cliente(int id, string nome,string cpf,string email,string paciente)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.Paciente = paciente;
        }
    }
}