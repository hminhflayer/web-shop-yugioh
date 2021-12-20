using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebShop.Data
{
    public class SeedData
    {
		private static readonly UserManager<User> userManager;
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new WebShopContext(serviceProvider.GetRequiredService<DbContextOptions<WebShopContext>>()))
			{
				context.Database.EnsureCreated();

				// Look for any data
				if (!context.Category.Any())
				{
					var Categorys = new Category[]
					{
					new Category{CategoryName = "Thẻ đơn - Card"},
					new Category{CategoryName = "Gói thẻ - Pack"},
					new Category{CategoryName = "Hộp - Box"},
					new Category{CategoryName = "Phụ kiện - Accessories"}
					};

					context.Category.AddRange(Categorys);
					context.SaveChanges();
				}

				if (!context.Provider.Any())
				{
					var providers = new Provider[]
					{
					new Provider{ProviderName = "Nhật Bản - JPN"},
					new Provider{ProviderName = "Hoa Kỳ - USA"},
					new Provider{ProviderName = "Anh - UK"}
					};

					context.Provider.AddRange(providers);
					context.SaveChanges();
				}

				if(!context.Product.Any())
                {
					var products = new Product[]
					{
						new Product {ProductName = "A Wingbeat of Giant Dragon", Amount = 50, Price = 8900, Image = "AWingbeatOfGiantDragon.jpg", Description = "Return 1 Level 5 or higher Dragon-Type monster you control to the hand, and if you do, destroy all Spell and Trap Cards on the field.", ProviderID = 1, CategoryId = 1},
						new Product {ProductName = "A-to-Z-Dragon Buster Cannon", Amount = 20, Price = 7500, Image = "A-to-Z-DragonBusterCannon.jpg", Description = "\"ABC-Dragon Buster\" + \"XYZ-Dragon Cannon\"\nMust be Special Summoned (from your Extra Deck) by banishing cards you control with the above original names, and cannot be Special Summoned by other ways. (You do not use \"Polymerization\".) During either player's turn, when your opponent activates a Spell/Trap Card, or monster effect: You can discard 1 card; negate the activation, and if you do, destroy that card. During either player's turn: You can banish this card, then target 1 each of your banished \"ABC-Dragon Buster\", and \"XYZ-Dragon Cannon\"; Special Summon them.", ProviderID = 2, CategoryId = 1},
						new Product {ProductName = "ABC-Dragon Buster", Amount = 30, Price = 11500, Image = "ABC-DragonBuster.jpg", Description = "\"A-Assault Core\" + \"B-Buster Drake\" + \"C-Crush Wyvern\"\r\nMust first be Special Summoned (from your Extra Deck) by banishing the above cards you control and/or from your GY. (You do not use \"Polymerization\".) Once per turn (Quick Effect): You can discard 1 card, then target 1 card on the field; banish it. During your opponent's turn (Quick Effect): You can Tribute this card, then target 3 of your banished LIGHT Machine Union monsters with different names; Special Summon them.", ProviderID = 1, CategoryId = 1},
						new Product {ProductName = "Absorouter Dragon", Amount = 25, Price = 10900, Image = "AbsorouterDragon.jpg", Description = "If you control a \"Rokket\" monster, you can Special Summon this card (from your hand). You can only Special Summon \"Absorouter Dragon\" once per turn this way. If this card is sent to the GY: You can add 1 \"Rokket\" monster from your Deck to your hand. You can only use this effect of \"Absorouter Dragon\" once per turn.", ProviderID = 2, CategoryId = 1},
						new Product {ProductName = "Dragon Seeker", Amount = 40, Price = 5600, Image = "DragonSeeker.jpg", Description = "When this card is Normal Summoned or Flip Summoned, destroy 1 face-up Dragon-Type monster on the field.", ProviderID = 3, CategoryId = 1},
						new Product {ProductName = "Solar Flare Dragon", Amount = 35, Price = 7600, Image = "SolarFlareDragon.jpg", Description = "While you control another Pyro-Type monster, this card cannot be attacked. During each of your End Phases: Inflict 500 damage to your opponent.", ProviderID = 1, CategoryId = 1},
						new Product {ProductName = "Thunder Dragons' Hundred Thunders", Amount = 50, Price = 5500, Image = "ThunderDragonsHundredThunders.jpg", Description = "Target 1 Thunder monster in your GY; Special Summon it, then you can Special Summon as many monsters with that same name as possible from your GY. The monster(s) Special Summoned by this effect are banished when they leave the field, also while they are face-up on the field, you cannot Special Summon monsters, except Thunder monsters. You can only activate 1 \"Thunder Dragons' Hundred Thunders\" per turn.", ProviderID = 2, CategoryId = 1},
						new Product {ProductName = "Thunder End Dragon", Amount = 37, Price = 6500, Image = "ThunderEndDragon.jpg", Description = "2 Level 8 Normal Monsters\nOnce per turn: You can detach 1 Xyz Material from this card; destroy all other monsters on the field.", ProviderID = 1, CategoryId = 1},
						new Product {ProductName = "Guardragon Pisty", Amount = 5, Price = 15000, Image = "GuardragonPisty.jpg", Description = "1 Level 4 or lower Dragon monster\r\nYou cannot Special Summon monsters, except Dragon monsters. During your Main Phase: You can target 1 of your Dragon monsters that is banished or in your GY; Special Summon it to your zone that 2 or more Link Monsters point to. You can only use this effect of \"Guardragon Pisty\" once per turn. You can only Special Summon \"Guardragon Pisty(s)\" once per turn.", ProviderID = 1, CategoryId = 1}
					};

					context.Product.AddRange(products);
					context.SaveChanges();
				}					

				if(!context.Roles.Any())
                {
					var roles = new IdentityRole[]
					{
						new IdentityRole{Id = "UserRole", Name = "User", NormalizedName = "USER"},
						new IdentityRole{Id = "AdminRole", Name = "Admin", NormalizedName = "ADMIN"}
					};

					context.Roles.AddRange(roles);
					context.SaveChanges();
				}

                if (!context.Users.Any())
                {
					var admin = new User
					{
						Email = "test1@gmail.com",
						FullName = "Cao Hoàng Minh",
						PhoneNumber = "0378108516",
						Address = "Châu Thành, An Giang",
						UserName = "Admin",
						EmailConfirmed = false,
					};
					IdentityResult result = userManager.CreateAsync(admin, "admin2703").Result;

					if (result.Succeeded)
					{
						IdentityUserRole<string> adminRole = new IdentityUserRole<string>
						{
							UserId = admin.Id,
							RoleId = "AdminRole"
						};

						context.UserRoles.Add(adminRole);
						context.SaveChanges();
					}
				}
            }
		}
	}
}
