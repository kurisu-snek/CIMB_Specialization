# Payment API Documentation

This document outlines the RESTful API endpoints for managing payment data.

Base URL: `/api/payment`

| Endpoint | HTTP Method	Description | Description |
|----------|-------------------------|-------------|
| /        | GET                     | Retrieves a list of all payment data.            |
| /        | POST                    | Creates a new payment record.            |
| /{id}    | GET                     | Retrieves a specific payment record by its ID.            |
| /{id}    | PUT                     | Updates an existing payment record.            |
| /{id}    | DELETE                  | Deletes an existing payment record.            |

Example Request Body (POST, PUT):

```JSON
{
  "id": int,
  "cardOwnerName": "string",
  "cardNumber": "DataType.CreditCard",
  "expirationDate": "yyyy-MM-dd",
  "securityCode": "string"
}
```

Response:

```JSON
{
  "PaymentDetailId": 1,
  "CardNumber": "3647384758492453",
  "CardOwnerName": "CJ",
  "ExpirationDate": "2028-03-09",
  "SecurityCode": "619"
}
```