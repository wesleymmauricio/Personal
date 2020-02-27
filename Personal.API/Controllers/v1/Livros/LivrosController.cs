using Microsoft.AspNetCore.Mvc;
using Personal.Domain.Entities.Personal;
using Personal.Domain.Interfaces.Applications.Personal;
using Personal.Domain.ViewModel.Persona.Livro;
using System;

namespace Personal.API.Controllers.v1.Livros
{
    [ApiController]
    [Route("api/livros")]
    public class LivrosController : BaseController
    {
        private readonly ILivroApplication _app;

        public LivrosController(ILivroApplication app)
        {
            _app = app;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int livroId)
        {
            try
            {
                if (livroId == 0)
                    return BadRequest("Invalid request");

                var livro = _app.GetById(livroId);

                if (livro == null)
                    return NotFound("Livro não encotrado!");

                return Ok(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var livros = _app.GetAll();

                if (livros == null)
                    return NotFound("Livros não encotrado");

                return Ok(livros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult Add([FromBody] LivroToInsertVM livroToInsert)
        {
            try
            {
                if (livroToInsert == null)
                    return BadRequest("Invalid request");

                var livro = new Livro();
                livro.CreatedBy = 1;
                livro.CreatedDate = DateTime.Now;
                livro.Editora = livroToInsert.Editora;
                livro.Escritor = livroToInsert.Escritor;
                livro.Titulo = livroToInsert.Titulo;
                livro.LastUpdatedBy = 1;
                livro.LastUpdatedDate = DateTime.Now;

                var livroId = _app.Add(livro);

                return Ok(livro);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] LivroToUpdateVM livroToUpdate, int livroId)
        {
            try
            {
                if (livroToUpdate == null)
                    return BadRequest("Invalid Resquest");

                if(livroId == 0)
                    return BadRequest("Invalid Request");
                
                if (livroId != livroToUpdate.LivroId)
                    return BadRequest("Conflito nos Ids");
                
                var livro = new Livro();
                livro.Editora = livroToUpdate.Editora;
                livro.Escritor = livroToUpdate.Escritor;
                livro.Titulo = livroToUpdate.Titulo;
                livro.LastUpdatedBy = 1;
                livro.LastUpdatedDate = DateTime.Now;

                _app.Update(livro);

                return NoContent();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int livroId)
        {
            try
            {
                if (livroId == 0)
                    return BadRequest("Invalid Id");

                _app.Delete(livroId);

                return NoContent();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
