using System;
using System.Diagnostics;
using Microsoft.Playwright;
using Reqnroll;

namespace IDESdemo1.StepDefinitions
{
    [Binding]
    public class US_123_AddProductStepDefinitions
    {

        [Given("User is the landing page")]
        public static async Task GivenUserIsTheLandingPage()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var context = await browser.NewContextAsync();

            var page = await context.NewPageAsync();
            await page.GotoAsync("https://commitquality.com/");
            await page.SetViewportSizeAsync(1366, 768);
            await Task.Delay(2000);
            await page.GetByTestId("add-a-product-button").ClickAsync();
            await Task.Delay(2000);
            await page.GetByTestId("product-textbox").ClickAsync();
            await page.GetByTestId("product-textbox").FillAsync("Porsche");
            await Task.Delay(2000);
            await page.GetByTestId("price-textbox").ClickAsync();
            await page.GetByTestId("price-textbox").FillAsync("149799");
            await Task.Delay(2000);
            await page.GetByTestId("date-stocked").FillAsync("2025-04-23");
            await Task.Delay(2000);
            await page.GetByTestId("submit-form").ClickAsync();
            await Task.Delay(7000);
        }

        [When("I click on addProduct")]
        public void WhenIClickOnAddProduct()
        {
            Debug.WriteLine("Charger");
        }

        [Then("I should reach the page add product")]
        public void ThenIShouldReachThePageAddProduct()
        {
            Debug.WriteLine("Charger");
        }

        [Given("Landing on add product page")]
        public static async Task GivenLandingOnAddProductPage()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var context = await browser.NewContextAsync();

            var page = await context.NewPageAsync();
            await page.GotoAsync("https://commitquality.com/add-product");
            await page.SetViewportSizeAsync(1366, 768);
            await Task.Delay(2000);
            await page.GetByTestId("product-textbox").ClickAsync();
            await page.GetByTestId("product-textbox").FillAsync("Porsche");
            await Task.Delay(2000);
            await page.GetByTestId("price-textbox").ClickAsync();
            await page.GetByTestId("price-textbox").FillAsync("149799");
            await Task.Delay(2000);
            await page.GetByTestId("date-stocked").FillAsync("2025-04-23");
            await Task.Delay(2000);
            await page.GetByTestId("submit-form").ClickAsync();
            await Task.Delay(7000);
        }

        [When("I fill product name")]
        public void WhenIFillProductName()
        {
            Debug.WriteLine("Charger");
        }

        [Then("I should able to add the product name")]
        public void ThenIShouldAbleToAddTheProductName()
        {
            Debug.WriteLine("Charger");
        }

        [When("I fill product price")]
        public void WhenIFillProductPrice()
        {
            Debug.WriteLine("Charger");
        }

        [Then("I should able to add the product price")]
        public static void ThenIShouldAbleToAddTheProductPrice()
        {
            Debug.WriteLine("Charger");
        }
    }
}
