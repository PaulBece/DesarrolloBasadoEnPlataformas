const express = require('express');
const { graphqlHTTP } = require('express-graphql');
const schema=require('./schema/schema');
const mongoose=require('mongoose');

const app=express();

mongoose.connect('mongodb+srv://Paul:password@cluster0.yrlh39c.mongodb.net/?retryWrites=true&w=majority');
mongoose.connection.once('open',()=>{
    console.log('connected to database');
})

app.use('/graphql',graphqlHTTP({
    schema,
    graphiql:true
}));

app.listen(4000,()=>{
    console.log('now listening for requests on port 4000');
});