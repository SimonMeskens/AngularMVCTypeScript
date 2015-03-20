/// <reference path="../../scripts/_references.d.ts" />
var angularMVCTypeScript;
(function (angularMVCTypeScript) {
    "use strict";
    var Home = (function () {
        function Home(BootstrapDataService) {
            angular.extend(this, BootstrapDataService.consumeNext());
        }
        Home.$inject = ["BootstrapDataService"];
        return Home;
    })();
    angularMVCTypeScript.Home = Home;
})(angularMVCTypeScript || (angularMVCTypeScript = {}));
//# sourceMappingURL=Home.js.map