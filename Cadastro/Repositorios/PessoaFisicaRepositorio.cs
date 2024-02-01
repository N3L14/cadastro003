﻿using Cadastro.Data;
using Cadastro.Models;
using Cadastro.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Repositorios
{
    public class PessoaFisicaRepositorio : IPessoaFisicaRepositorio
    {
        private readonly CadastroDbContext _dbContext;

        public PessoaFisicaRepositorio(CadastroDbContext cadastroDbContext)
        {
            _dbContext = cadastroDbContext;
        }

        public async Task<PessoaFisicaModel> BuscarId(int id)
        {
            return await _dbContext.PessoaFisica.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<PessoaFisicaModel>> BuscarTodasPessoas()
        {
            return await _dbContext.PessoaFisica.ToListAsync();
        }

        public async Task<PessoaFisicaModel> Adicionar(PessoaFisicaModel pessoaFisica)
        {
            _dbContext.PessoaFisica.Add(pessoaFisica);
            _dbContext.SaveChanges();

            return pessoaFisica;
        }

        public async Task<PessoaFisicaModel> Atualizar(PessoaFisicaModel pessoaFisica, int id)
        {
            PessoaFisicaModel pessoaFisicaPorId = await BuscarId(id);

            if(pessoaFisicaPorId == null)
            {
                throw new Exception($"Pessoa Fisica com o ID: {id} não foi localizada no banco de dados.");
            }

            pessoaFisicaPorId.Nome = pessoaFisica.Nome;
            pessoaFisicaPorId.Sobrenome = pessoaFisica.Sobrenome;
            pessoaFisicaPorId.DataNascimento = pessoaFisica.DataNascimento;
            pessoaFisicaPorId.Email = pessoaFisica.Email;
            pessoaFisicaPorId.CPF = pessoaFisica.CPF;
            pessoaFisicaPorId.RG = pessoaFisica.RG;



        }



        public Task<bool> Deletar(int Id)
        {
            throw new NotImplementedException();
        }
    }
}