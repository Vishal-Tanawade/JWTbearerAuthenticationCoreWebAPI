#  JWTbearerAuthenticationCoreWebAPI
## Asp .Net Core Web API
- Date: 03-June-2022
- After running this project we cannot fetch product list without authentication, so first run POST Method to generate Token
- In post Method Enter Email and password in Json Format, it will generate Token
- Goto Get Method => Paste URL of get method from swagger
- In Header Enter <b> Authorization </b> as key and in Value enter <b> Bearer {Token} </b> => click on send => it will show product list in body 

![Screenshot (272)](https://user-images.githubusercontent.com/58319263/172161229-264c9a24-26af-42f8-ba88-a32af9a6cff2.png)


