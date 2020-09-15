using NHibernate;
using OnlineShop.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{

    public class HomeController : Controller
    {

        private readonly ISession _session;

        public HomeController()
        {
            _session = NHsession.OpenSession();
        }

        public async Task<ActionResult> Index()
        {
            if (await _session.QueryOver<Product>().RowCountAsync() == 0)
                await DumbData();

            IList<Product> product = new List<Product>();
            using (var tx = _session.BeginTransaction())
            {
                var query = await _session.QueryOver<Product>().ListAsync();
                product = query;
            }

            return View(product);
        }

        public async Task<ActionResult> Cart()
        {
            IList<Cart> cart = new List<Cart>();
            using (var tx = _session.BeginTransaction())
            {
                var query = await _session.QueryOver<Cart>().ListAsync();
                cart = query;
            }

            return View(cart);
        }

        public async Task DumbData()
        {
            using (var tx = _session.BeginTransaction())
            {
                var item1 = new Product
                {
                    Name = "Fashion Mens Tracksuit Fashion Designer T-Shirt + Pants 1 Piece Sets Solid Color Brand Suits 2020 High Quality Tracksuits mens tracksuit",
                    Picture = "images/1.jpg",
                    Price = 100m
                };
                await _session.SaveAsync(item1);

                var item2 = new Product
                {
                    Name = "Fashion Mens Tracksuit Fashion Designer T-Shirt",
                    Picture = "images/2.jpg",
                    Price = 50m
                };
                await _session.SaveAsync(item2);

                var item3 = new Product
                {
                    Name = "Tracksuit Fashion Designer T-Shirt + Pants 2 Piece Sets",
                    Picture = "images/3.jpg",
                    Price = 70m
                };
                await _session.SaveAsync(item3);

                var item4 = new Product
                {
                    Name = "Fashion Designer Sets High Quality ",
                    Picture = "images/4.jpg",
                    Price = 80m
                };
                await _session.SaveAsync(item4);

                var item5 = new Product
                {
                    Name = " 2019 Fashion Designer Tracksuit Spring Autumn Casual Unisex Brand Sportswear Mens Tracksuits High Quality Hoodies Mens Clothing ",
                    Picture = "images/5.jpg",
                    Price = 90m
                };
                await _session.SaveAsync(item5);

                var item6 = new Product
                {
                    Name = " Mens Designers Fashion Tracksuit Letters Embroidery Luxury Summer Sportswear Short Sleeves Pullover Jogger Pants Suits O-Neck Sportsuit ",
                    Picture = "images/6.jpg",
                    Price = 95m
                };
                await _session.SaveAsync(item6);

                var item7 = new Product
                {
                    Name = " Mens Beach Designer Tracksuits Summer 20ss Fashion Beach Seaside Holiday Shirts Shorts Sets Mens 2020 Luxury Designer Sets Outfits ",
                    Picture = "images/7.jpg",
                    Price = 220m
                };
                await _session.SaveAsync(item7);

                var item8 = new Product
                {
                    Name = " Designer Men Summer Tracksuit Tee shirts homme Set Mens T Shirt Shorts Pants Men Casual two piece outfits Tee Shirts shorts Size S-2XL T365 ",
                    Picture = "images/8.jpg",
                    Price = 320m
                };
                await _session.SaveAsync(item8);

                var item9 = new Product
                {
                    Name = " BALMAIN Men Tracksuit 2020 T-shirt+Short Pant+Long Pant 3 Piece Sets Solid Color Outfit Suits High Quality Tracksuits ",
                    Picture = "images/9.jpg",
                    Price = 77m
                };
                await _session.SaveAsync(item9);

                var item10 = new Product
                {
                    Name = " Northern winte Designer Tracksuit Men Luxury Sweat Suits Autumn Brand Mens Jogger Suits Jacket + Pants Sets Sporting WOMEN Suit Hip Hop Sets ",
                    Picture = "images/10.jpg",
                    Price = 80m
                };
                await _session.SaveAsync(item10);

                var item11 = new Product
                {
                    Name = " Mens Designer Tracksuits Survetement Solid Color Track Suit Jogging Suits Men Pantalon de survêtement Multiple Choice Tracksuits ",
                    Picture = "images/11.jpg",
                    Price = 90m
                };
                await _session.SaveAsync(item11);

                var item12 = new Product
                {
                    Name = " Designer New Fashion Men Shirts Shorts Set Summer Casual Printed Shirt Homme Short Male Printing Dress Suit Sets Plus Size 5XL ",
                    Picture = "images/12.jpg",
                    Price = 95m
                };
                await _session.SaveAsync(item12);

                var item13 = new Product
                {
                    Name = " Summer Mens Tracksuit Maserati Printed Men Stall Collar V-Neck Short Sleeves Pullover With Casual Jogger Pants Suits Homme Sportsuit ",
                    Picture = "images/13.jpg",
                    Price = 18m
                };
                await _session.SaveAsync(item13);

                var item14 = new Product
                {
                    Name = " Summer Men Sport Tracksuit MRSREATI Printed Slim Cool Short Sleeves T-shirt With Joggers Pants Casual Suit ",
                    Picture = "images/14.jpg",
                    Price = 56m
                };
                await _session.SaveAsync(item4);

                var item15 = new Product
                {
                    Name = " Men's Designer Tracksuit Jackets Set Fashion Running Tracksuits Men Sports Suit Letter printing Clothing Track Kit Medusa Sportswear ",
                    Picture = "images/15.jpg",
                    Price = 46m
                };
                await _session.SaveAsync(item15);

                var item16 = new Product
                {
                    Name = " 2020 mens designers Letter printing Running Sets sweatshirt tracksuit suits t shirts + pants mens coats jackets Casual sweatshirts ",
                    Picture = "images/16.jpg",
                    Price = 24m
                };
                await _session.SaveAsync(item16);

                var item17 = new Product
                {
                    Name = " Pullover Sets Men Tracksuits 2020 Casual Hoodies Pants Mens Sportswear Pant Hoody Sweatshirt Male Suits Jogging Sweatpant 2 Pcs S-3XL ",
                    Picture = "images/17.jpg",
                    Price = 19m
                };
                await _session.SaveAsync(item17);

                var item18 = new Product
                {
                    Name = " Men Zipper Tracksuit Fashion Side Striped Hooded Hoodies Jacket Pants Track Suits Men Casual 2 Pieces Sweatsuit ",
                    Picture = "images/18.jpg",
                    Price = 95m
                };
                await _session.SaveAsync(item18);

                var item19 = new Product
                {
                    Name = " Mens Beach Designer Tracksuits Summer 20ss Fashion Beach Seaside Holiday Shirts Shorts Sets Mens 2020 Luxury Designer Sets Outfits ",
                    Picture = "images/19.jpg",
                    Price = 22m
                };
                await _session.SaveAsync(item19);

                var item20 = new Product
                {
                    Name = " Designer Men Summer Tracksuit Tee shirts homme Set Mens T Shirt Shorts Pants Men Casual two piece outfits Tee Shirts shorts Size S-2XL T365 ",
                    Picture = "images/20.jpg",
                    Price = 84m
                };
                await _session.SaveAsync(item20);

                await tx.CommitAsync();
            }
        }
    }
}
