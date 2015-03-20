/// <reference path="../../scripts/_references.d.ts" />

module angularMVCTypeScript {
    "use strict";

    export class Home implements IHomeViewModel {
        helloAngular;

        static $inject = ["BootstrapDataService"];

        constructor(BootstrapDataService: IBootstrapDataService) {
            angular.extend(this, BootstrapDataService.consumeNext());
        }
    }
}