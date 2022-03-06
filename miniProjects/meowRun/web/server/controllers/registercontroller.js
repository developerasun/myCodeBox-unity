
const NewUser = async(req,res) =>{
    const {user, pwd, email} = req.body
    if (!user || !pwd || !email) return res.status(400).json({'message': 'Username,password and Email  are required'});

}    
    



