require('dotenv').config();
const express = require('express');
const app = express()
const mongoose = require('mongoose');
const connectDB = require('./config/dbConn')
const Port = process.env.PORT;

connectDB();
// built-in middleware to handle urlencoded data
app.use(express.urlencoded({ extended: false}));

// built-in middleware for json
app.use(express.json());







app.listen(Port,  console.log(`Server running on port ${Port}`))
