/**
 * @param {string} val
 * @return {Object}
 */
var expect = function(val) {
    return {
        toBe(comp) {
            if (val === comp)
                return true
            else
                throw "Not Equal"
        },
        notToBe(comp) {
            if (val === comp)
                throw "Equal"
            else
                return true
        }
    }
};

/**
 * expect(5).toBe(5); // true
 * expect(5).notToBe(5); // throws "Equal"
 */