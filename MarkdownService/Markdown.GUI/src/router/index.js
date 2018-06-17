import Vue from "vue";
import Router from "vue-router";
import Home from "@/components/Home";
import ReadDoc from "@/components/ReadDocument";

Vue.use(Router);

export default new Router({
    routes: [
        {
            path: "/",
            name: "Home",
            component: Home
        },
        {
            path: "/document/:docid",
            name: "ReadDocument",
            component: ReadDoc
        }
    ]
});
