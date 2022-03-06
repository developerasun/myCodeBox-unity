const router = require('express').Router();
const authcontroller = require('../controllers/authcontrollers')

router.post('/', authcontroller.userLogin );

module.exports = router