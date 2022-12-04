/**
 * @param {string} s
 * @return {boolean}
 */
 var halvesAreAlike = function(s) {
	const a = s.substring(0, s.length/2);
	const b = s.substring(s.length/2);
	const vowvels = ['a', 'e', 'i', 'o', 'u'];
	let vowvelsDiff = 0;

	for (let index = 0; index < a.length; index++) {
		const chA = a[index].toLowerCase();
		const chB = b[index].toLowerCase();
		vowvels.includes(chA) ? vowvelsDiff++ : vowvelsDiff;
		vowvels.includes(chB) ? vowvelsDiff-- : vowvelsDiff;

		if(vowvelsDiff > a.length - index)
			return false;
	}

	return vowvelsDiff == 0;
}