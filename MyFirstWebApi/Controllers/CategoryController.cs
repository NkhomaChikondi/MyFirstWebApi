using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using MyfirstApi.Core.DTOs;
using MyFirstApi.Data.Repository.IRepository;
using MyFirstApi.Models;

namespace MyFirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CategoryController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;      
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // get all categories in the system
            Category categoryResult = _unitOfWork.Category.GetAll().First();

            // map the result with categoryDto
            
            //var config = new MapperConfiguration(cfg => {
            //    cfg.CreateMap<Category, CategoryDTO>();
                // Additional mappings can be added here
           // });
            //IMapper mapper = config.CreateMapper();
            //var destinationObject = mapper.Map<CategoryDTO>(categoryResult);

            var categoryDTOs = this._mapper.Map<CategoryDTO>(categoryResult);
            return Ok(categoryDTOs);
        }

        [HttpPost]        

        public IActionResult Create([FromBody] CreateCategoryDTO createCategory)
        {
            if(ModelState.IsValid)
            {
                var newCategory = new Category
                {
                    Name = createCategory.Name,
                    OrderNumber = createCategory.OrderNumber,
                };
                _unitOfWork.Category.Add(newCategory);
                _unitOfWork.Save();

                string location = Url.Action(nameof(Create));
                return Created(location, this._mapper.Map<CreateCategoryDTO>(newCategory));             
            }
            return BadRequest(ModelState);           
        }
    }
}
