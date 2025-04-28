<template>
    <div class="container py-5">
        <h1 class="display-4 fw-semibold mb-4">Cozy Beach House</h1>
        <img src="/images/cozy_beach_house.jpg" class="w-100 rounded-4 mb-4" style="height: 500px; object-fit: cover;" alt="Beach House">

        <p class="lead text-muted mb-4">Relax and unwind in this beautiful beachside getaway.</p>

        <div class="bg-light rounded-4 p-4 mb-4">
            <div class="border-bottom py-2">
                <strong>Location:</strong> Malibu, CA
            </div>
            <div class="border-bottom py-2">
                <strong>Price:</strong> $250/night
            </div>
            <div class="py-2">
                <strong>Amenities:</strong> Pool, Wi-Fi, Kitchen, Ocean View
            </div>
        </div>

        <router-link to="/listings" class="btn btn-secondary">Back to Listings</router-link>
    </div>
</template>

<script>
    import { defineComponent } from 'vue';

    export default defineComponent({
        name: 'DetailsView'
    });
</script>

<style scoped>
</style>
