﻿using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
	public class ImageController : Controller
	{
		private readonly IImageService _imageService;

		public ImageController(IImageService imageService)
		{
			_imageService = imageService;
		}

		public IActionResult Index()
		{
			var values = _imageService.GetListAll();
			return View(values);
		}

		[HttpGet]
		public IActionResult AddImage()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddImage(Image ımage)
		{
			ImageValidator validationRules = new ImageValidator();
			ValidationResult results = validationRules.Validate(ımage);
			if (results.IsValid)
			{
				_imageService.Insert(ımage);
				return RedirectToAction("Index");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}

		public IActionResult DeleteImage(int id)
		{
			var value = _imageService.GetById(id);
			_imageService.Delete(value);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult EditImage(int id)
		{
			var value = _imageService.GetById(id);
			return View(value);
		}

		[HttpPost]
		public IActionResult EditImage(Image ımage)
		{
			ImageValidator validationRules = new ImageValidator();
			ValidationResult results = validationRules.Validate(ımage);
			if (results.IsValid)
			{
				_imageService.Update(ımage);
				return RedirectToAction("Index");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
	}
}
