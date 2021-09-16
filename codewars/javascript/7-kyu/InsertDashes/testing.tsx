const num = 454793123456;

function insertDash(num: number) {
  const numAsString = num.toString();
  const numArray = numAsString.split("");

  for (let index = 0; index < numArray.length; index++) {
    numArray.slice(index, index + 1);
    if (index % 2 !== 0) {
      numArray.splice(index, index + 1, "-");
    }
  }
}
