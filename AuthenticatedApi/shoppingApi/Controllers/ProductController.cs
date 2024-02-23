using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using ShoppingApi.Services;

[Authorize]
public class ProductController : Controller
{}