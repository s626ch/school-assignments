function calcUlation() {
    pennies = document.getElementById("moneyamount").value;
    //
    dollars = Math.floor((pennies / 100));
    pennies %= 100;
    document.getElementById("fAmnt").innerHTML = dollars;
    //
    quarters = Math.floor((pennies / 25));
    document.getElementById("qAmnt").innerHTML = quarters;
    pennies %= 25;
    //
    dimes = Math.floor((pennies / 10));
    document.getElementById("dAmnt").innerHTML = dimes;
    pennies %= 10;
    //
    nickels = Math.floor((pennies / 5));
    document.getElementById("nAmnt").innerHTML = nickels;
    pennies %= 5;
    //
    document.getElementById("pAmnt").innerHTML = pennies;
}
function clearInps() {
    document.getElementById("moneyamount").value = ''; // input money amount, pennies
    document.getElementById("fAmnt").innerHTML = ''; //   remaining dollars
    document.getElementById("qAmnt").innerHTML = ''; //   remaining quarters
    document.getElementById("dAmnt").innerHTML = ''; //   remaining dimes
    document.getElementById("nAmnt").innerHTML = ''; //   remaining nickels
    document.getElementById("pAmnt").innerHTML = ''; //   remaining pennies
}