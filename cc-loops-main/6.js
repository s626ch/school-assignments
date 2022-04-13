// Write your code below

bobsFollowers = ["JoeyShmoey", "Mowerboy", "LeanDean", "DamnDaniel"];
tinasFollowers = ["Mowerboy","DamnDaniel","StickyKeys"];
mutualFollowers = [];
for(let i=0;i<bobsFollowers.length;i++){
  for(let j=0;j<tinasFollowers.length;j++){
    if(bobsFollowers[i]===tinasFollowers[j]){
      mutualFollowers.push(tinasFollowers[j]);
      console.log(mutualFollowers);
    }
  }
}