import Vue from "vue";
import Router from "vue-router";
import Home from "@/components/Home";
import ReadDocument from "@/components/ReadDocument";
import EditDocument from "@/components/EditDocument";

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
            component: ReadDocument
        },
        {
            path: "/document/:docid/edit",
            name: "EditDocument",
            component: EditDocument
        }
    ]
});
