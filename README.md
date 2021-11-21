# Reviews and Ratings

# API example requests

# Register
curl --location --request POST 'http://localhost:5000/api/Auth/Register' --header 'Content-Type: application/json' -d '{"email": "test@api.ie", "password":"Api@2021", "confirmpassword":"Api@2021"}'

# Login
curl --location --request POST 'http://localhost:5000/api/Auth/Login' --header 'Content-Type: application/json' -d '{"email": "test@api.ie", "password":"Api@2021"}'

# Create Review with invalid object
curl --location --request POST 'http://localhost:5000/api/Establishment/CreateReview' --header 'Content-Type: application/json' -d '{"name":"Invalid Review"}' -H "Authorization: Bearer YOUR_TOKEN_HERE"

# Create Review with Website Feedback
curl --location --request POST 'http://localhost:5000/api/Establishment/CreateReview' --header 'Content-Type: application/json' -d '{"IdEstablishment":"2a84b0f2-ccf9-4d99-9a86-9e2dd5bf1a5a", "IdCustomer":"1677b925-1e40-4626-b347-888e5f883492", "Review":"This is a new created review", "Rating":3, "IdCompany": "c052811f-2f7c-495d-b087-a0fc1dc5b1c6", "WebsiteFeedback": "This is the website feedback"}' -H "Authorization: Bearer YOUR_TOKEN_HERE"

# Get Review by Establishment
curl --location --request GET 'http://localhost:5000/api/Establishment/GetReview?IdEstablishment=e5b25e3d-e815-48d4-8c5a-6e232cabc9a6'

# Considerations

* The Authorization by JWT is used on the API, and the Individual Authentication is used on the Management, but due to conflict and the lack of time to make them both work together only the API has Authorization active.

* The system is using Sqlite, to change to use MSSQL is necessary to add the nuget package for MSSQL, change the Startup and replace the Migration.

* The Database tables is created based on the Models of the system.

* Establishment is one of the units of a Company the table for the same have not been created due to the lack of time, but it will be necessary to validate the data sent by the customer.

* It might be necessary to create a table for Customer based on IdentityUser to add fields like address and others fields as necessary.