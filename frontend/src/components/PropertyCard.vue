<template>
    <div class="property-card">
        <img :src="'/images/' + property.image" class="property-img" :alt="property.title">
        <div class="property-body">
            <h5 class="property-title">{{ property.title }}</h5>
            <p class="property-text">{{ property.description }}</p>
            <router-link :to="'/details'" class="btn custom-btn">View Details</router-link>
        </div>
    </div>
</template>

<script>
import { defineComponent } from 'vue';

export default defineComponent({
  name: 'PropertyCard',
  props: {
    property: {
      type: Object,
      required: true
    }
  }
});
</script>

<style scoped>
    .property-card {
        border: 1px solid #e6e6e6;
        border-radius: 12px;
        overflow: hidden;
        transition: transform 0.3s, box-shadow 0.3s;
        margin-bottom: 25px;
    }

        .property-card:hover {
            transform: translateY(-5px);
            box-shadow: 0 10px 20px rgba(0,0,0,0.1);
        }

    .property-img {
        width: 100%;
        height: 200px;
        object-fit: cover;
    }

    .property-body {
        padding: 15px;
    }

    .property-title {
        font-size: 18px;
        font-weight: 600;
        margin-bottom: 10px;
    }

    .property-text {
        color: #717171;
        margin-bottom: 15px;
    }

    .btn {
        display: inline-block;
        padding: 8px 16px;
        border-radius: 8px;
        text-decoration: none;
        font-weight: 500;
        cursor: pointer;
    }
</style>