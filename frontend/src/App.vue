<template>
    <NavBar />
    <router-view />
    <FooterComponent />
</template>

<script>
    import { defineComponent } from 'vue';
    import NavBar from './components/NavBar.vue';
    import FooterComponent from './components/FooterComponent.vue';

    export default defineComponent({
        name: 'App',
        components: {
            NavBar,
            FooterComponent
        }
    });
</script>