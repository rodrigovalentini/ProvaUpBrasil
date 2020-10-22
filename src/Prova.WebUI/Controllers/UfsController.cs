using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Prova.Business.Interfaces;
using Prova.Business.Models;
using Prova.WebUI.ViewModels;

namespace Prova.WebUI.Controllers
{
    public class UfsController : BaseController
    {
        private readonly IUfRepository _ufRepository;
        private readonly IMapper _mapper;

        public UfsController(IUfRepository UfRepository, IMapper mapper)
        {
            _ufRepository = UfRepository;
            _mapper = mapper;
        }

        //Get da Index
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<UfViewModel>>(await _ufRepository.GetAll()));
        }

        public async Task<IActionResult> Details(Guid id)
        {

            var ufViewModel = _mapper.Map<UfViewModel>(await _ufRepository.GetById(id));
            if (ufViewModel == null)
            {
                return NotFound();
            }

            return View(ufViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        //Salvar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UfViewModel ufViewModel)
        {
            if (!ModelState.IsValid) return View(ufViewModel);

            var uf = _mapper.Map<Uf>(ufViewModel);
            await _ufRepository.Add(uf);
            return RedirectToAction("Index");

        }

        // Get do Edit
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null) return NotFound();
         
            var ufViewModel = _mapper.Map<UfViewModel>(await _ufRepository.GetById(id));
            if (ufViewModel == null) return NotFound();
            
            return View(ufViewModel);
        }

        // Post do edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, UfViewModel ufViewModel)
        {
            if (id != ufViewModel.Id) return NotFound();
            if (!ModelState.IsValid) return View(ufViewModel);

            var uf = _mapper.Map<Uf>(ufViewModel);
            await _ufRepository.Update(uf);

            return RedirectToAction("Index");
        }

        // Get do Delete
        public async Task<IActionResult> Delete(Guid id)
        {
            var ufViewModel = _mapper.Map<UfViewModel>(await _ufRepository.GetById(id));
            if (ufViewModel == null) return NotFound();

            return View(ufViewModel);
        }

        // POST: Ufs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var ufViewModel = await _ufRepository.GetById(id);
            if (ufViewModel == null) return NotFound();
            await _ufRepository.Remove(id);

            return RedirectToAction("Index");
        }
    }
}
