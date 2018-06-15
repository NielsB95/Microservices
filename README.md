# Microservices [![Build Status](https://travis-ci.org/NielsB95/Microservices.svg?branch=master)](https://travis-ci.org/NielsB95/Microservices)[![codecov](https://codecov.io/gh/NielsB95/Microservices/branch/master/graph/badge.svg)](https://codecov.io/gh/NielsB95/Microservices)

In this repository, I will work out different concepts regarding microservices. While creating these services I hope to get a better understanding of how microservices work and what it takes to develop them.

- [X] Core<br/>
Core will be included in every microservice. This 'Core' will contain some utility functions, some controllers that will be included in every service (e.g. heartbeat controller) and the validation function of the JSON Web Token. 

- [ ] Service discovery<br/>
Service discovery should be able to find out where the instances are running. This is also the place where microservices can ask for the location of other services. This will become handy when services need to communicate with each other.

- [ ] Accountservice<br/>
This microservice will be responsible for authentication. When someone is authenticated by this service access should be provided on all other services (based on permissions). JSON Web Tokens will be used (https://jwt.io/) to generate tokens.

- [ ] Microservices dashboard<br/>
When you have many services you need to be able to monitor the status. This dashboard should visualize the services that are currently running and how well they are performing. It would be nice if this dashboard also enables you to launch and closes services.
