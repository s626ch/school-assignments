const cards = ['diamond', 'spade', 'heart', 'club'];
let currentCard;
// Write your code below
while(currentCard != 'spade') {
  currentCard = cards[Math.floor(Math.random() * 4)];
  console.log(currentCard);
}