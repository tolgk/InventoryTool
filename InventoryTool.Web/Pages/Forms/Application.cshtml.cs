using InventoryTool.Application.Interfaces.Services;
using InventoryTool.Domain.Entities;
using InventoryTool.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RegistrySystem.Pages.Forms
{
    [Authorize]
    public class ApplicationModel : PageModel
    {
        private readonly IApplicationEntityService _applicationService;
        private readonly IModuleEntityService _moduleService;
        public AppModel AppModel = new();

        public ApplicationModel(IApplicationEntityService applicationService, IModuleEntityService moduleEntityService)
        {
            _applicationService = applicationService;
            _moduleService = moduleEntityService;
        }

        //[Route("/")]
        //[]
        public async Task<IActionResult> OnGet()
        {
            AppModel.Applications = await _applicationService.GetAllAsync();
            AppModel.Modules = await _moduleService.GetAllAsync();
            return Page();
        }

        public IActionResult OnPostAddApp(AppModel model)
        {
            var newApp = new Application()
            {
                Name = model.Name,
                Description = model.Description
            };

            _applicationService.AddAsync(newApp);
            _applicationService.SaveAsync();
            return RedirectToAction("/Forms/Application");
        }

        public async Task<IActionResult> OnPostUpdateApp(AppModel model)
        {
            var app = await _applicationService.GetSingleAsync(a => a.Id == model.Id);
            if (app!=null)
            {
                app.Name = model.Name;
                app.Description = model.Description;
                _applicationService.Update(app);
                await _applicationService.SaveAsync();
            }
            
            
            return RedirectToAction("/Forms/Application");
        }
        public async Task<IActionResult> OnPostEditSubModule(AppModel model)
        {
            var module = await _moduleService.GetSingleAsync(m => m.Id == model.SubModuleId);
            if (module != null)
            {
                module.Name = model.ModuleName;

                module.Path = model.SubModulePath;

                module.Description = model.ModuleDescription;
                _moduleService.Update(module);
                await _moduleService.SaveAsync();
            }
          
            return RedirectToAction("/Forms/Application");
        }

        public async Task<IActionResult> OnPostAddNewModule(AppModel model)
        {
            var module = new Module()
            {
                AppId = model.Id,
                Name = model.ModuleName,
                Path = model.SubModulePath,
                Description = model.ModuleDescription
            };
            await _moduleService.AddAsync(module);
            await _moduleService.SaveAsync();
           
            return RedirectToAction("/Forms/Application");
        }
    }
}
