﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Domains.Models;
using WebApplication.Domains.Repositories;
using WebApplication.Domains.Services.Communication;
using WebApplication.Domains.Repositories;

namespace WebApplication.Domains.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnityOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository, IUnityOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }

        public async Task<CategoryResponse> SaveAsync(Category category)
        {
            try
            {
                await _categoryRepository.AddAsync(category);
                await _unitOfWork.CompleteAsync();  

                return new CategoryResponse(category);
            }
            catch (Exception ex)
            {
                return new CategoryResponse($"An error has occurred when saving the category: {ex.Message}");
            }
        }

        public async Task<CategoryResponse> UpdateAsync(int id, Category category)
        {
            var existingCategory = await _categoryRepository.FindByIdAsync(id);

            if(existingCategory == null) return new CategoryResponse("Category not found.");

            existingCategory.Name = category.Name;

            try
            {
                _categoryRepository.Update(existingCategory);
                await _unitOfWork.CompleteAsync();

                return new CategoryResponse(existingCategory);
            }
            catch (Exception ex)
            {
                return new CategoryResponse($"An error occurred when updating the category: {ex.Message}");
            }
        }

        public async Task<CategoryResponse> DeleteAsync(int id)
        {
            var existingCategory = await _categoryRepository.FindByIdAsync(id);

            if(existingCategory == null) return new CategoryResponse("Category not found.");

            try
            {
                _categoryRepository.Remove(existingCategory);
                await _unitOfWork.CompleteAsync();

                return new CategoryResponse(existingCategory);
            }
            catch (Exception ex)
            {
                return new CategoryResponse($"An error occurred when deleting the category: {ex.Message}");
            }
        }
    }
}
