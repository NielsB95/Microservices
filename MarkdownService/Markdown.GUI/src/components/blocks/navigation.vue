<template>
    <div class="header">
        <b-navbar toggleable="md" type="dark" variant="info" sticky>
        <b-navbar-toggle target="nav_collapse"></b-navbar-toggle>
        <b-navbar-brand href="#/">Markdown</b-navbar-brand>

        <b-collapse is-nav id="nav_collapse">
            <b-navbar-nav>
            <b-nav-item href="#/">Home</b-nav-item>
            </b-navbar-nav>

            <!-- Right aligned nav items -->
            <b-navbar-nav class="ml-auto">
            <b-nav-item-dropdown right>
                <!-- Using button-content slot -->
                <template slot="button-content">
                <em>User</em>
                </template>
                <b-dropdown-item href="#">Profile</b-dropdown-item>
                <b-dropdown-item href="#">Signout</b-dropdown-item>
            </b-nav-item-dropdown>
            </b-navbar-nav>

        </b-collapse>
        </b-navbar>
    </div>
</template>
<script>
export default {
  name: "Navigation"
};
</script>
<style scoped>
.header {
  padding-bottom: 2em;
}

.navbar-custom {
  background-color: #ff5500;
}
</style>
