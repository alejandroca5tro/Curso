angular.module("accumulator", [])
    .controller('AccumulatorController', function($scope) {
        //código del controlador
        this.increase = 10;
        this.total = this.increase;

        this.add = function() {;
            this.total += parseInt(this.increase);
        }
        this.subs = function() {
            this.total -= parseInt(this.increase);
        }
    })