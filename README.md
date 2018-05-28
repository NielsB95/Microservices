# Microservices [![Build Status](https://travis-ci.org/NielsB95/Microservices.svg?branch=master)](https://travis-ci.org/NielsB95/Microservices)

## Docker commands
The following command can be used to create a docker image from the AccountService. This command needs to be executed from the root of this repository.

```docker build . -f AccountService/Accounts/Dockerfile```

## Run docker image
```docker run -d -p 80:80 <image-id>```
