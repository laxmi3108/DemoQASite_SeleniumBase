using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Net;
using System.Collections.ObjectModel;
using DemoQASite;

namespace DemoQASite
{
    public class Women : Selenium_Base
    {
        public void GoToAutomation(IWebDriver Driver)
        {
            open("http://automationpractice.com/index.php");
            wait(500);
        }

        public void GoToWomen(IWebDriver Driver)
        {
            click(FindXPath("//a[text()='Women']"));
            wait(1000);
        }

        public void WomenCatalog(IWebDriver Driver)
        {
            scrollPage(0, 200);
            wait(1000);

            click(FindXPath("//input[@id='layered_category_4']"));
            wait(4000);

            scrollPage(0, 500);
            wait(2000);

            scrollPage(0, -500);
            wait(2000);

            click(FindXPath("//input[@id='layered_category_8']"));
            wait(5000);

            scrollPage(0, 800);
            wait(2000);

            scrollPage(0, -700);
            wait(2000);

            click(FindXPath("//a[@rel='layered_category_4']//i[@class='icon-remove']"));
            wait(5000);

            click(FindXPath("//input[@id='layered_id_attribute_group_3']"));
            wait(5000);

            scrollPage(0, 400);

            click(FindXPath("//input[@id='layered_id_attribute_group_16']"));
            wait(7000);


        }

        public void HoverToItem(IWebDriver Driver)
        {
            scrollPage(0, 200);

            hoverOnto(FindXPath("//img[@src='http://automationpractice.com/img/p/1/2/12-home_default.jpg']"));
            wait(2000);

            hoverOnto(FindXPath("//img[@src='http://automationpractice.com/img/p/1/6/16-home_default.jpg']"));
            wait(2000);

            hoverOnto(FindXPath("//img[@src='http://automationpractice.com/img/p/2/0/20-home_default.jpg']"));
            wait(2000);

        }

        public void More(IWebDriver Driver)
        {
            hoverOnto(FindXPath("//img[@src='http://automationpractice.com/img/p/1/2/12-home_default.jpg']"));
            wait(2000);

            click(FindXPath("//a[@href='http://automationpractice.com/index.php?id_product=5&controller=product']//span[text()='More']"));
            wait(2000);

            scrollPage(0, 400);
            wait(3000);

            hoverOnto(FindXPath("//img[@id='thumb_13']"));
            wait(2000);

            hoverOnto(FindXPath("//img[@id='thumb_14']"));
            wait(2000);

            hoverOnto(FindXPath("//img[@id='thumb_15']"));
            wait(2000);

            click(FindXPath("//img[@id='thumb_14']"));
            wait(2000);

            clickWithAction(FindXPath("//a[@title='Next']"));
            wait(2000);

            clickWithAction(FindXPath("//a[@title='Next']"));
            wait(2000);

            clickWithAction(FindXPath("//a[@title='Previous']"));
            wait(2000);

            clickWithAction(FindXPath("//a[@title='Previous']"));
            wait(2000);

            click(FindXPath("//a[@title='Close']"));
            wait(2000);

            click(FindXPath("//a[@class='btn btn-default button-plus product_quantity_up']"));
            wait(2000);

            click(FindXPath("//a[@class='btn btn-default button-minus product_quantity_down']"));
            wait(2000);

            click(FindXPath("//div[@class='selector']"));
            wait(2000);

            click(FindXPath("//option[text()='L']"));
            wait(2000);

            click(FindXPath("//a[@id='color_14']"));
            wait(2000);

            scrollPage(0, 500);
            wait(3000);

            BackBrowser();
            wait(2000);

            BackBrowser();
            wait(2000);

            BackBrowser();
            wait(7000);
        }


        public void QuickView(IWebDriver Driver)
        {
            scrollPage(0, -100);
            wait(2000);

            hoverOnto(FindXPath("//img[@src='http://automationpractice.com/img/p/1/2/12-home_default.jpg']"));
            wait(5000);

            click(FindXPath("//a[@href='http://automationpractice.com/index.php?id_product=5&controller=product']//span[text()='Quick view']"));
            wait(4000);

            clickWithAction(FindXPath("//a[@title='Close']"));
            wait(2000);
        }

        public void color(IWebDriver Driver)
        {
            hoverOnto(FindXPath("//img[@src='http://automationpractice.com/img/p/1/2/12-home_default.jpg']"));
            wait(2000);

            click(FindXPath("//a[@id='color_20']"));
            wait(2000);

            scrollPage(0, 700);
            wait(2000);

            BackBrowser();
            wait(2000);
        }

        public void AddToCart(IWebDriver Driver)
        {
            hoverOnto(FindXPath("//img[@src='http://automationpractice.com/img/p/1/2/12-home_default.jpg']"));
            wait(2000);

            click(FindXPath("//a[@data-id-product='5']//span[text()='Add to cart']"));
            wait(2000);

            click(FindXPath("//a[@title='Proceed to checkout']"));
            wait(2000);

            scrollPage(0, 500);
            wait(2000);

            click(FindXPath("//a[@title='Continue shopping']"));
            wait(2000);
        }

        public void feature(IWebDriver Driver)
        {
            scrollPage(0, 800);
            wait(2000);

            click(FindXPath("//input[@id='layered_id_feature_5']"));
            wait(5000);

            click(FindXPath("//input[@id='layered_id_feature_11']"));
            wait(5000);

            click(FindXPath("//input[@id='layered_id_feature_13']"));
            wait(5000);

            click(FindXPath("//input[@id='layered_id_feature_17']"));
            wait(5000);

            scrollPage(0, 400);
            wait(2000);

            click(FindXPath("//input[@id='layered_manufacturer_1']"));
            wait(5000);

            click(FindXPath("//input[@id='layered_condition_new']"));
            wait(5000);
        }

        public void Range(IWebDriver Driver)
        {
            var slide = FindXPath("//a[@class='ui-slider-handle ui-state-default ui-corner-all'][2]");

            dragAndDropOffset(slide, -40, 0);
            wait(2000);
        }

        public void Information(IWebDriver Driver)
        {
            scrollPage(0, 100);
            wait(2000);

            click(FindXPath("//a[@title='Delivery']"));
            wait(2000);

            BackBrowser();
            wait(2000);

            click(FindXPath("//a[@title='Legal Notice']"));
            wait(2000);

            BackBrowser();
            wait(2000);

            click(FindXPath("//a[@title='Terms and conditions of use']"));
            wait(2000);

            scrollPage(0, 200);
            wait(2000);

            BackBrowser();
            wait(2000);

            click(FindXPath("//a[@title='About us']"));
            wait(2000);

            scrollPage(0, 200);
            wait(2000);

            BackBrowser();
            wait(2000);

            click(FindXPath("//a[@title='Secure payment']"));
            wait(2000);

            BackBrowser();
            wait(2000);

            click(FindXPath("//a[@title='Our stores']"));
            wait(2000);

            scrollPage(0, 200);
            wait(2000);

            BackBrowser();
            wait(2000);
        }

        public void ShortBy(IWebDriver Driver)
        {
            scrollPage(0, -500);
            wait(2000);

            click(FindXPath("//select[@id='selectProductSort']"));
            wait(2000);

            click(FindXPath("//option[text()='Product Name: A to Z']"));
            wait(5000);
        }

        public void List(IWebDriver Driver)
        {
            click(FindXPath("//a[@title='List']"));
            wait(3000);

            scrollPage(0, 200);
        }

        public void AddToWishList(IWebDriver Driver)
        {
            click(FindXPath("//a[@class='addToWishlist wishlistProd_2']"));
            wait(3000);

            click(FindXPath("//a[@title='Close']"));
            wait(3000);
        }

        public void AddToCompare(IWebDriver Driver)
        {
            click(FindXPath("//a[@class='add_to_compare' and @data-id-product='2']"));
            wait(3000);

            scrollPage(0, 200);
            wait(1000);

            click(FindXPath("//button[@class='btn btn-default button button-medium bt_compare bt_compare']"));
            wait(3000);

            click(FindXPath("//span[text()='Continue Shopping']"));
            wait(3000);
        }

        public void Cart(IWebDriver Driver)
        {
            click(FindXPath("//a[text()='Women']"));
            wait(1000);

            click(FindXPath("//a[@title='View my shopping cart']"));
            wait(3000);

            scrollPage(0, 200);
            wait(1000);

            click(FindXPath("//a[@title='Continue shopping']"));
            wait(3000);
        }

        public void Search(IWebDriver Driver)
        {
            sendKeys(FindXPath("//input[@id='search_query_top']"), "printed dress");
            wait(2000);

            click(FindXPath("//li[text()='Summer Dresses > Printed Chiffon Dress']"));
            wait(3000);

            scrollPage(0, 400);
            wait(2000);

            BackBrowser();
            wait(1000);
        }

        public void SubCategories(IWebDriver Driver)
        {
            scrollPage(0, 200);
            wait(1000);

            click(FindXPath("//a[@title='Tops' and @class='img']"));
            wait(3000);

            scrollPage(0, 300);
            wait(1000);

            click(FindXPath("//a[@title='T-shirts' and @class='img']"));
            wait(3000);

            scrollPage(0, 700);
            wait(1000);

            BackBrowser();
            wait(2000);

            click(FindXPath("//a[@title='Blouses' and @class='img']"));
            wait(3000);

            scrollPage(0, 500);
            wait(1000);

            BackBrowser();
            wait(1000);

            BackBrowser();
            wait(1000);

            scrollPage(0, -600);
            wait(2000);

            close();
        }
    }
}
