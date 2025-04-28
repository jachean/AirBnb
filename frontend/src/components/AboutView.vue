<template>
    <div class="container py-5">
        <h1 class="display-4 fw-semibold mb-3">About Airbnb</h1>
        <p class="lead text-muted mb-5">
            We connect travelers with unique stays and unforgettable experiences.
        </p>

        <div class="row">
            <div class="col-md-6 mb-4">
                <h3 class="h4 text-primary fw-semibold mb-3">Our Mission</h3>
                <p class="text-secondary">
                    To create a world where anyone can belong anywhere.
                </p>
            </div>

            <div class="col-md-6 mb-4">
                <h3 class="h4 text-primary fw-semibold mb-3">Contact</h3>
                <p class="text-secondary mb-2">Email: support@airbnb.com</p>
                <p class="text-secondary mb-0">Phone: +1 (123) 456-7890</p>
            </div>
        </div>
    </div>
</template>

<script>
    import { defineComponent } from 'vue';

    export default defineComponent({
        name: 'AboutView'
    });
</script>

<style scoped>
</style>
