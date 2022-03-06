using System.Text.Json;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_commerce.CustomerSite.Services;
using E_commerce.CustomerSite.Models;

namespace E_commerce.CustomerSite.Views.Medicine;
public class DefaultPageModel : PageModel
{
    private readonly IMedicineService _medicineService;
    private readonly IClassifyService _classifyService;
    private readonly IMapper _mapper;
    public CollectionPageModel(IMedicineService medicineService, IMapper mapper)
    {
        _medicineService = medicineService;
        _mapper = mapper;
    }


    [BindProperty(SupportsGet = true)]
    public List<Medicine> medicines { get; set; }


    public async Task<IActionResult> OnGetAsync()
    {
        // var resp = await _productService.GetProductById((int)id);
        // var data = MyResponseMapper.MapJson<RookiesFashion.ClientSite.Models.Product>((JsonElement)resp.Data);
        // product = _mapper.Map<ProductVM>(data);
        return Page();
    }

    public async Task<IActionResult> OnGetWithFilterAsync()
    {

        return Page();
    }

}