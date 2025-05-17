# Fastrak Demo

This repository demonstrates a **proof-of-concept** .NET 8 application for receiving and processing Shopify webhooks. It features:

- A **WebhookAuthFilter** for authenticating Shopify webhook requests using HMAC.
- An **OrdersController** (and optionally other controllers) to handle incoming webhooks.
- A **WebhookManager** service that processes **orders**, **refunds**, and **products** with placeholder/pseudocode logic for database operations.
- **EF Core** integration (using SQLite for demo) to store data in a local DB.
- Usage of **RestSharp** to optionally fetch inventory data from Shopify.

> ([POC.md](./POC.md)) describing a broader concept called FASTRAK, which demonstrates multi-platform webhook management (Shopify, Alibaba, Amazon, etc.), integrative steps, and example models.

> **Note**: This is a minimal demonstration. In a real production app, you’d expand the logic to handle line items, refunds, concurrency, advanced logging, etc.

---

## Table of Contents
1. [Local Setup Instructions](#local-setup-instructions)
2. [Project Structure](#project-structure)
3. [Technical Documentation](#technical-documentation)
    - [WebhookAuthFilter](#webhookauthfilter)
    - [OrdersController](#orderscontroller)
    - [WebhookManager](#webhookmanager)
    - [EF Core (SQLite) Setup](#ef-core-sqlite-setup)
4. [Test Data & Usage](#test-data--usage)
5. [Extended Proof of Concept Documentation (FASTRAK)](#extended-proof-of-concept-documentation-fastrak)

---

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed.
- [SQLite](https://www.sqlite.org/index.html) (optional, but recommended for local development with a persistent file).
- A **Shopify Partner** or **Shopify Store** if you plan to test real webhooks (otherwise you can simulate with cURL/Postman).
- Basic knowledge of C#, EF Core, ASP.NET Core.

---

## Local Setup Instructions

1. Check/Adjust Configuration:
- In appsettings.Development.json, set:
```json
{
  "ConnectionStrings": {
    "DemoDb": "Data Source=demo.db"
  },
  "Shopify": {
    "Client_Secret": "YOUR_SHOPIFY_APP_SECRET"
  }
}
```
Replace YOUR_SHOPIFY_APP_SECRET with your actual Shopify app secret if testing real webhooks.
2. Restore & Build:
```shell
dotnet restore
dotnet build
```
3. Run Migrations (optional, if you want a persistent SQLite database):
```shell
dotnet ef migrations add InitialCreate
dotnet ef database update
```
4. Run the App:
```shell
dotnet run
```

## Test Data & Usage
1. Simulate a Shopify Order Webhook (Locally)
   You can test using cURL or Postman (though you must supply the correct HMAC header to pass the filter). For a quick test bypassing HMAC, you can temporarily remove or comment out the [ServiceFilter(typeof(WebhookAuthFilter))] attribute in OrdersController, then:
    ```shell
    curl -X POST http://localhost:5000/api/orders \
         -H "Content-Type: application/json" \
         -d '{
           "id": 123456789,
           "name": "#1001",
           "customer": {
             "id": 987654321,
             "email": "test@example.com"
           }
         }'
    ```
2. Testing Real Shopify Webhooks
   1. Ngrok or similar:
      Expose your local ASP.NET app using [ngrok](https://ngrok.com/). For example:
      ```shell
      ngrok http https://localhost:5001
      ```
      Copy the forwarding HTTPS URL (e.g., https://1234abcd.ngrok.io).
   2.	Shopify Admin:
         In your Shopify store’s admin, create a webhook under Settings > Notifications (or via the Admin API) pointing to https://YOUR_NGROK_DOMAIN.ngrok.io/api/orders.
   3.	Test:
         Perform an action in Shopify (e.g., create a test order).
         Shopify will send the event to your local application, which the filter will verify using your Shopify:Client_Secret.
