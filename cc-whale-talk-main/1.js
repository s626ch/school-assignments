let input = "Aloha! My name is Stitch, and I'm cute and fluffy!";
let vowels = ['a','e','i','o','u','A','E','I','O','U'];
let resultArray = [];

for (let i=0;i<input.length;i++) {
  // console.log(i);
  if (input[i]==='e'||input[i]==='E'){
      resultArray.push(input[i]);
  }
  if (input[i]==='u'||input[i]==='U'){
      resultArray.push(input[i]);
  }
  for (let j=0;j<vowels.length;j++){
    // console.log(j);
    if (input[i]===vowels[j]){
      resultArray.push(vowels[j]);
    }
  }
}
console.log(resultArray);
let resultString = resultArray.join('');
console.log(resultString.toUpperCase(resultString.toString()));