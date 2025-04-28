<template>
    <div class="container privacy-container">
        <h1 class="privacy-title">Privacy Policy</h1>
        <div class="privacy-content">
            <p>Your privacy is important to us. This page outlines how we handle your data.</p>

            <h2>Information Collection</h2>
            <p>We collect information that you provide directly to us when you use our platform.</p>

            <h2>How We Use Your Information</h2>
            <p>We use the information we collect to provide, maintain, and improve our services.</p>

            <h2>Contact Us</h2>
            <p>If you have any questions about our privacy policy, please contact us.</p>
        </div>
    </div>
</template>

<script>
import { defineComponent } from 'vue';

export default defineComponent({
  name: 'PrivacyView'
});
</script>

<style scoped>
    .privacy-container {
        padding: 50px 15px;
    }

    .privacy-title {
        font-size: 36px;
        font-weight: 600;
        margin-bottom: 30px;
    }

    .privacy-content {
        max-width: 800px;
    }

        .privacy-content h2 {
            font-size: 24px;
            margin-top: 30px;
            margin-bottom: 15px;
        }

        .privacy-content p {
            line-height: 1.6;
            color: #484848;
            margin-bottom: 20px;
        }
</style>