<template>
    <div class="container listings-container">
        <h1 class="listings-title">Available Listings</h1>
        <div class="row">
            <div v-for="(property, index) in properties" :key="index" class="col-md-4">
                <PropertyCard :property="property" />
            </div>
        </div>
    </div>
</template>

<script>
import { defineComponent, ref } from 'vue';
import PropertyCard from './PropertyCard.vue';

export default defineComponent({
  name: 'ListingsView',
  components: {
    PropertyCard
  },
  setup() {
    const properties = ref([
      {
        id: 1,
        title: 'Cozy Beach House',
        description: 'Enjoy stunning ocean views from this charming home.',
        image: 'cozy_beach_house.jpg'
      },
      {
        id: 2,
        title: 'Mountain Cabin',
        description: 'Escape to nature in this secluded mountain retreat.',
        image: 'mountain_cabin.jpg'
      },
      {
        id: 3,
        title: 'Urban Loft',
        description: 'Stay in the heart of the city with modern amenities.',
        image: 'urban_loft.jpg'
      }
    ]);

    return {
      properties
    };
  }
});
</script>

<style scoped>
    .listings-container {
        padding: 50px 15px;
    }

    .listings-title {
        font-size: 32px;
        font-weight: 600;
        margin-bottom: 30px;
        color: #222;
    }
</style>