var nombre = document.getElementById('name');
var lastName = document.getElementById('lastName');
var age = document.getElementById('age');
var error = document.getElementById('error');
error.style.color = 'black';

function submitForm(){
    console.log('sending form..');
    
    var ErrorMessage = [];
    if(nombre.value === null || nombre.value === ''){
        ErrorMessage.push('ENTER YOUR NAME');       
    }
    if(lastName.value === null || lastName.value === ''){
        ErrorMessage.push('ENTER YOUR LAST NAME');
    }
    if(age.value === null || age.value === ''){
        ErrorMessage.push('ENTER YOUR AGE');
    }
      error.innerHTML = ErrorMessage.join(', ');   
        
      return false; 
} 
 function ClearForm(){
     document.getElementById("form").reset();
     
     console.log("cleareado");
 }
