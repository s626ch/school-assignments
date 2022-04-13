// func call but with default provided if no input given
// set the param to a default value, default is used if no input is given
function greeting (name = 'stranger') {
    console.log(`Hello, ${name}!`)
}
   
greeting('Nick') // Output: Hello, Nick!
greeting() // Output: Hello, stranger!   
// this is an example snippet but hell, it's helpful