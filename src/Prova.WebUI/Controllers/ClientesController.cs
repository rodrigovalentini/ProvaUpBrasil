using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Prova.Business.Interfaces;
using Prova.Business.Models;
using Prova.WebUI.Data;
using Prova.WebUI.ViewModels;

namespace Prova.WebUI.Controllers
{
    public class ClientesController : BaseController
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClientesController(IClienteRepository ClienteRepository, IMapper mapper)
        {
            _clienteRepository = ClienteRepository;
            _mapper = mapper;
        }

        // GET do index
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ClienteViewModel>>(await _clienteRepository.GetAll()));
        }

        // GET dos detalhes
        public async Task<IActionResult> Details(Guid id)
        {
            var clienteViewModel = _mapper.Map<ClienteViewModel>(await _clienteRepository.GetById(id));
            if (clienteViewModel == null)
            {
                return NotFound();
            }

            return View(clienteViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        // Salvar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClienteViewModel clienteViewModel)
        {
            if (!ModelState.IsValid) return View(clienteViewModel);

            var cliente = _mapper.Map<Cliente>(clienteViewModel);
            await _clienteRepository.Add(cliente);
            return RedirectToAction("Index");
        }

        // GET do editar
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null) return NotFound();

            var clienteViewModel = _mapper.Map<ClienteViewModel>(await _clienteRepository.GetById(id));
            if (clienteViewModel == null) return NotFound();

            return View(clienteViewModel);
        }

        // Post do editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, ClienteViewModel clienteViewModel)
        {
            if (id != clienteViewModel.Id) return NotFound();
            if (!ModelState.IsValid) return View(clienteViewModel);

            var cliente = _mapper.Map<Cliente>(clienteViewModel);
            await _clienteRepository.Update(cliente);

            return RedirectToAction("Index");
        }

        // GET do deletar
        public async Task<IActionResult> Delete(Guid id)
        {
            var clienteViewModel = _mapper.Map<ClienteViewModel>(await _clienteRepository.GetById(id));
            if (clienteViewModel == null) return NotFound();

            return View(clienteViewModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var clienteViewModel = await _clienteRepository.GetById(id);
            if (clienteViewModel == null) return NotFound();
            await _clienteRepository.Remove(id);

            return RedirectToAction("Index");
        }

      
    }
}
