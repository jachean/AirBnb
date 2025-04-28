<template>
    <nav class="navbar navbar-expand-lg navbar-light bg-white shadow-sm sticky-top">
        <div class="container">
            <router-link class="navbar-brand d-flex align-items-center" to="/">
                <img src="../assets/vue.svg" alt="Airbnb" height="30" class="me-2" />
                Airbnb
            </router-link>

            <button class="navbar-toggler"
                    type="button"
                    @click="toggleMenu"
                    aria-controls="navbarSupportedContent"
                    :aria-expanded="isOpen.toString()"
                    aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div :class="['collapse', 'navbar-collapse', { show: isOpen }]"
                 id="navbarSupportedContent">
                <ul class="navbar-nav d-flex flex-lg-row gap-3 align-items-center mb-2 mb-lg-0">
                    <li class="nav-item">
                        <router-link class="nav-link" to="/">Home</router-link>
                    </li>
                    <li class="nav-item">
                        <router-link class="nav-link" to="/listings">Listings</router-link>
                    </li>
                    <li class="nav-item">
                        <router-link class="nav-link" to="/about">About</router-link>
                    </li>
                    <li class="nav-item">
                        <router-link class="nav-link" to="/contact">Contact</router-link>
                    </li>
                    <li class="nav-item">
                        <router-link class="nav-link" to="/login">Login</router-link>
                    </li>
                    <li class="nav-item">
                        <router-link class="nav-link" to="/register">Register</router-link>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
</template>

<script>
    export default {
        name: 'NavBar',
        data() {
            return {
                isOpen: false,
            };
        },
        methods: {
            toggleMenu() {
                this.isOpen = !this.isOpen;
            },
        },
    };
</script>

<style scoped>
    .collapse {
        transition: all 0.3s ease;
    }
</style>
