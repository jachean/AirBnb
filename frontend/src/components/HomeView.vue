<template>
    <div class="hero">
        <div class="container">
            <div class="hero-content">
                <h1 class="hero-title">Welcome to Airbnb</h1>
                <p class="hero-subtitle">Find unique places to stay and explore new adventures.</p>
                <router-link to="/listings" class="btn custom-btn btn-lg">View Listings</router-link>
            </div>
        </div>
    </div>
</template>

<script>
import { defineComponent } from 'vue';

export default defineComponent({
  name: 'HomeView'
});
</script>

<style scoped>
    .hero {
        padding: 100px 0;
        text-align: center;
        background: linear-gradient(rgba(255,255,255,0.9), rgba(255,255,255,0.9)), url('/images/hero-bg.jpg');
        background-size: cover;
        background-position: center;
    }

    .hero-content {
        max-width: 800px;
        margin: 0 auto;
    }

    .hero-title {
        font-size: 48px;
        font-weight: 700;
        margin-bottom: 20px;
        color: #222;
    }

    .hero-subtitle {
        font-size: 24px;
        color: #717171;
        margin-bottom: 30px;
    }

    .btn-lg {
        padding: 12px 24px;
        font-size: 18px;
    }
</style>