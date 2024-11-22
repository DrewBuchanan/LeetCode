/**
 * @param {number} n
 * @return {Function} counter
 */
var createCounter = function(n) {
    let number = n;
    return function() {
        number++;
        return number-1;
    };
};

/** 
 * const counter = createCounter(10)
 * counter() // 10
 * counter() // 11
 * counter() // 12
 */